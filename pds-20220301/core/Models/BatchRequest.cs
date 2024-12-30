// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BatchRequest : TeaModel {
        /// <summary>
        /// <para>The child requests.</para>
        /// <para>The number of child requests. Valid value: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("requests")]
        [Validation(Required=false)]
        public List<BatchRequestRequests> Requests { get; set; }
        public class BatchRequestRequests : TeaModel {
            /// <summary>
            /// <para>The request parameters of a child request. The parameter value must be a JSON string. For more information, see the topic of the corresponding child request.</para>
            /// <para>Before you specify the request body, you must specify a header by using Content-Type. Content-Type can only be set to application/json.</para>
            /// </summary>
            [NameInMap("body")]
            [Validation(Required=false)]
            public Dictionary<string, object> Body { get; set; }

            /// <summary>
            /// <para>The header of a child request, which indicates the type of the data specified in the request body.</para>
            /// </summary>
            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// <para>The ID of the child request. The ID is used to associate a child request with a response. The ID of a child request must be unique.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93433894994ad2e1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The method of a child request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>POST</description></item>
            /// <item><description>GET</description></item>
            /// <item><description>PUT</description></item>
            /// <item><description>DELETE</description></item>
            /// <item><description>HEAD</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>The API path of a child request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>/file/get: queries the information about a file.</description></item>
            /// <item><description>/file/update: modifies the information about a file.</description></item>
            /// <item><description>/file/search: searches for a file.</description></item>
            /// <item><description>/file/copy: copies a file or folder.</description></item>
            /// <item><description>/file/move: moves a file or folder.</description></item>
            /// <item><description>/file/delete: deletes a file or folder.</description></item>
            /// <item><description>/file/get_download_url: queries the download URL of a file.</description></item>
            /// <item><description>/file/get_share_link_download_url: queries the download URL of a file in a share.</description></item>
            /// <item><description>/recyclebin/trash: moves a file or folder to the recycle bin.</description></item>
            /// <item><description>/recyclebin/restore: restores a file or folder.</description></item>
            /// <item><description>/file/put_usertags: adds tags to a user.</description></item>
            /// <item><description>/file/delete_usertags: removes tags from a user.</description></item>
            /// <item><description>/drive/get: queries the information about a drive.</description></item>
            /// <item><description>/user/get: queries the information about a user.</description></item>
            /// <item><description>/group/get: queries the information about a group.</description></item>
            /// <item><description>/share_link/create: creates a share.</description></item>
            /// <item><description>/share_link/update: modifies a share.</description></item>
            /// <item><description>/share_link/cancel: cancels a share.</description></item>
            /// <item><description>/share_link/list: queries shares.</description></item>
            /// <item><description>/share_link/get: queries the information about a share.</description></item>
            /// <item><description>/share_link/get_share_token: queries an access token of a share.</description></item>
            /// <item><description>/async_task/get: queries the information about an asynchronous task.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/file/get</para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The type of the resource that you want to manage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>file: a file.</description></item>
        /// <item><description>drive: an individual drive or a team drive.</description></item>
        /// <item><description>user: a user.</description></item>
        /// <item><description>group: a group.</description></item>
        /// <item><description>membership: a group member.</description></item>
        /// <item><description>share_link: a share.</description></item>
        /// <item><description>async_task: an asynchronous task.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

    }

}
