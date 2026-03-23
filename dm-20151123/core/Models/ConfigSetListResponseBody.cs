// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ConfigSetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of configuration sets.</para>
        /// </summary>
        [NameInMap("ConfigSets")]
        [Validation(Required=false)]
        public List<ConfigSetListResponseBodyConfigSets> ConfigSets { get; set; }
        public class ConfigSetListResponseBodyConfigSets : TeaModel {
            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of associated sender addresses.</para>
            /// </summary>
            [NameInMap("FromAddresses")]
            [Validation(Required=false)]
            public List<string> FromAddresses { get; set; }

            /// <summary>
            /// <para>The ID of the configuration set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The IP pool information.</para>
            /// </summary>
            [NameInMap("IpPool")]
            [Validation(Required=false)]
            public ConfigSetListResponseBodyConfigSetsIpPool IpPool { get; set; }
            public class ConfigSetListResponseBodyConfigSetsIpPool : TeaModel {
                /// <summary>
                /// <para>The ID of the associated IP pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("IpPoolId")]
                [Validation(Required=false)]
                public string IpPoolId { get; set; }

                /// <summary>
                /// <para>The name of the associated IP pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("IpPoolName")]
                [Validation(Required=false)]
                public string IpPoolName { get; set; }

            }

            /// <summary>
            /// <para>The name of the configuration set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Indicates whether a next page of results exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
