// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ModifyUserGroupsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use asynchronous message links to change the user group.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to obtain the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The users. You can specify 1 to 100 users.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public List<ModifyUserGroupsRequestUser> User { get; set; }
        public class ModifyUserGroupsRequestUser : TeaModel {
            /// <summary>
            /// <para>The user group to be changed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>users: ordinary permissions, which are suitable for ordinary users that need only to submit and debug jobs.</description></item>
            /// <item><description>wheel: sudo permissions, which are suitable for administrators who need to manage clusters. In addition to submitting and debugging jobs, you can also run sudo commands to install software and restart nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>users</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188572.html">ListUsers</a> operation to query the usernames in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user11</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
