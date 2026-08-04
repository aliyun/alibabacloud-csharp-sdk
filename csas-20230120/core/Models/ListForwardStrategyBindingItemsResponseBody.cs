// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListForwardStrategyBindingItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of forwarding rule bindings.</para>
        /// </summary>
        [NameInMap("ForwardStrategyBindingItemsList")]
        [Validation(Required=false)]
        public List<ListForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItemsList> ForwardStrategyBindingItemsList { get; set; }
        public class ListForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItemsList : TeaModel {
            /// <summary>
            /// <para>The forwarding rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fs-41a7891ff6568421</para>
            /// </summary>
            [NameInMap("ForwardId")]
            [Validation(Required=false)]
            public string ForwardId { get; set; }

            /// <summary>
            /// <para>The binding items.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItemsListItems> Items { get; set; }
            public class ListForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItemsListItems : TeaModel {
                /// <summary>
                /// <para>The ID of the internal-facing application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pa-application-104b6b97b7f0c5d9</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <para>The name of the internal-facing application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>437008</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <para>The internal-facing tag ID.</para>
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
                /// <para>nieshirui.nsr</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

                /// <summary>
                /// <para>The user group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ug-xxxxxx</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

                /// <summary>
                /// <para>The user group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaaaa</para>
                /// </summary>
                [NameInMap("UserGroupName")]
                [Validation(Required=false)]
                public string UserGroupName { get; set; }

            }

            /// <summary>
            /// <para>The policy matching target type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: all users.</description></item>
            /// <item><description><b>UserGroupNormal</b>: specific user groups.</description></item>
            /// <item><description><b>ApplicationAll</b>: all internal-facing applications.</description></item>
            /// <item><description><b>Application</b>: specific internal-facing applications.</description></item>
            /// <item><description><b>Tag</b>: internal-facing application tags.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UserGroupAll</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

        }

        /// <summary>
        /// <para>The binding item type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Application</b>: internal-facing application</description></item>
        /// <item><description><b>UserGroup</b>: user group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Application</para>
        /// </summary>
        [NameInMap("ItemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5F79AE39-6622-5292-87EF-DE45631DE4D7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
