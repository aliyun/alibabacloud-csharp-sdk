// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetNisNetworkRankingRequest : TeaModel {
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1684373600099</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1684379093000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<GetNisNetworkRankingRequestFilter> Filter { get; set; }
        public class GetNisNetworkRankingRequestFilter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lb-2zxxxxz1d</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Protocol</para>
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bps</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AccessInternetIpV4</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseCrossAccount")]
        [Validation(Required=false)]
        public bool? UseCrossAccount { get; set; }

    }

}
