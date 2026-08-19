// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ModifyForwardStrategyBindingItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The binding items of the forwarding rule after this modification.</para>
        /// </summary>
        [NameInMap("ForwardStrategyBindingItems")]
        [Validation(Required=false)]
        public ModifyForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItems ForwardStrategyBindingItems { get; set; }
        public class ModifyForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItems : TeaModel {
            /// <summary>
            /// <para>The forwarding rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fs-849ac29396d9ea98</para>
            /// </summary>
            [NameInMap("ForwardId")]
            [Validation(Required=false)]
            public string ForwardId { get; set; }

            /// <summary>
            /// <para>The binding content. This parameter is not returned when MatchMode is <b>UserGroupAll</b> or <b>ApplicationAll</b>.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ModifyForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItemsItems> Items { get; set; }
            public class ModifyForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItemsItems : TeaModel {
                /// <summary>
                /// <para>The private network access application ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pa-application-104b6b97b7f0c5d9</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <para>The private network access application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OA System</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <para>The private network access tag ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag-4c8b988bb0ffdfb3</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <para>The tag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Finance System</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

                /// <summary>
                /// <para>The user group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usergroup-3f9a2c7e10b4d856</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

                /// <summary>
                /// <para>The user group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>R&amp;D Department</para>
                /// </summary>
                [NameInMap("UserGroupName")]
                [Validation(Required=false)]
                public string UserGroupName { get; set; }

            }

            /// <summary>
            /// <para>The policy matching target type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: associates with all users.</description></item>
            /// <item><description><b>UserGroupNormal</b>: associates with specific user groups.</description></item>
            /// <item><description><b>ApplicationAll</b>: all private network applications.</description></item>
            /// <item><description><b>Application</b>: specific private network applications.</description></item>
            /// <item><description><b>Tag</b>: private network application tags.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Application</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5F79AE39-6622-5292-87EF-DE45631DE4D7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
