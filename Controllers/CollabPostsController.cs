using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using collabnetwork.Models;
using collabnetwork.Data;

namespace collabnetwork.Controllers
{
    public class CollabPostsController
    {
        public class PostsController : Controller
    {
        private readonly CollabPostsDbContext  _context;

        public PostsController(CollabPostsDbContext context)
        {
            _context = context;
        }

        // GET: CollabPost

        // GET: CollabPost {ID}
        
        // POST : CollabPost

        // PUT : CollabPost

        //DELETE : CollabPost

        private bool PostExists(int id)
        {
            return _context.CollabPosts.Any(e => e.Id == id);
        }
    }
    }
}