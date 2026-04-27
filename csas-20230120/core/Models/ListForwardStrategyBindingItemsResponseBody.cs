// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListForwardStrategyBindingItemsResponseBody : TeaModel {
        [NameInMap("ForwardStrategyBindingItemsList")]
        [Validation(Required=false)]
        public List<ListForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItemsList> ForwardStrategyBindingItemsList { get; set; }
        public class ListForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItemsList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>fs-41a7891ff6568421</para>
            /// </summary>
            [NameInMap("ForwardId")]
            [Validation(Required=false)]
            public string ForwardId { get; set; }

            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItemsListItems> Items { get; set; }
            public class ListForwardStrategyBindingItemsResponseBodyForwardStrategyBindingItemsListItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pa-application-104b6b97b7f0c5d9</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>437008</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tag-4c8b988bb0ffdfb3</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nieshirui.nsr</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ug-xxxxxx</para>
                /// </summary>
                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aaaaa</para>
                /// </summary>
                [NameInMap("UserGroupName")]
                [Validation(Required=false)]
                public string UserGroupName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UserGroupAll</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

        }

        /// <summary>
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
