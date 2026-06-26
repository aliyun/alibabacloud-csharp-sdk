// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateBatchConsumerResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of consumer objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<CreateBatchConsumerResponseBodyItems> Items { get; set; }
        public class CreateBatchConsumerResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The complete API key. This value is returned only in the current response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxx</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The API key status. Default value: Active.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("ApiStatus")]
            [Validation(Required=false)]
            public string ApiStatus { get; set; }

            /// <summary>
            /// <para>The ID of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg-xxxxxx</para>
            /// </summary>
            [NameInMap("ConsumerGroupId")]
            [Validation(Required=false)]
            public string ConsumerGroupId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-mqveroemc***</para>
            /// </summary>
            [NameInMap("ConsumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <para>The consumer tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ConsumerTag")]
            [Validation(Required=false)]
            public string ConsumerTag { get; set; }

            /// <summary>
            /// <para>The gateway instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("GwClusterId")]
            [Validation(Required=false)]
            public string GwClusterId { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The consumer status. Default value: Enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// <para>Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7E6A8FD-C50B-46B2-BA85-D8B8D3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
