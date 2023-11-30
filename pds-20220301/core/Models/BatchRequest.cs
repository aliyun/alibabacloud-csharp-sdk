// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BatchRequest : TeaModel {
        /// <summary>
        /// The child requests.
        /// 
        /// The number of child requests. Valid value: 1 to 100.
        /// </summary>
        [NameInMap("requests")]
        [Validation(Required=false)]
        public List<BatchRequestRequests> Requests { get; set; }
        public class BatchRequestRequests : TeaModel {
            /// <summary>
            /// The request parameters of a child request. The parameter value must be a JSON string. For more information, see the topic of the corresponding child request.
            /// 
            /// Before you specify the request body, you must specify a header by using Content-Type. Content-Type can only be set to application/json.
            /// </summary>
            [NameInMap("body")]
            [Validation(Required=false)]
            public Dictionary<string, string> Body { get; set; }

            /// <summary>
            /// The header of a child request, which indicates the type of the data specified in the request body.
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// The ID of the child request. The ID is used to associate a child request with a response. The ID of a child request must be unique.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The method of a child request. Valid values:
            /// 
            /// *   POST
            /// *   GET
            /// *   PUT
            /// *   DELETE
            /// *   HEAD
            /// </summary>
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// The API path of a child request. Valid values:
            /// 
            /// *   /file/get: queries the information about a file.
            /// *   /file/update: modifies the information about a file.
            /// *   /file/search: searches for a file.
            /// *   /file/copy: copies a file or folder.
            /// *   /file/move: moves a file or folder.
            /// *   /file/delete: deletes a file or folder.
            /// *   /file/get_download_url: queries the download URL of a file.
            /// *   /file/get_share_link_download_url: queries the download URL of a file in a share.
            /// *   /recyclebin/trash: moves a file or folder to the recycle bin.
            /// *   /recyclebin/restore: restores a file or folder.
            /// *   /file/put_usertags: adds tags to a user.
            /// *   /file/delete_usertags: removes tags from a user.
            /// *   /drive/get: queries the information about a drive.
            /// *   /user/get: queries the information about a user.
            /// *   /group/get: queries the information about a group.
            /// *   /share_link/create: creates a share.
            /// *   /share_link/update: modifies a share.
            /// *   /share_link/cancel: cancels a share.
            /// *   /share_link/list: queries shares.
            /// *   /share_link/get: queries the information about a share.
            /// *   /share_link/get_share_token: queries an access token of a share.
            /// *   /async_task/get: queries the information about an asynchronous task.
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The type of the resource that you want to manage. Valid values:
        /// 
        /// *   file: a file.
        /// *   drive: an individual drive or a team drive.
        /// *   user: a user.
        /// *   group: a group.
        /// *   membership: a group member.
        /// *   share_link: a share.
        /// *   async_task: an asynchronous task.
        /// 
        /// <!---->
        /// 
        /// *   <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

    }

}
