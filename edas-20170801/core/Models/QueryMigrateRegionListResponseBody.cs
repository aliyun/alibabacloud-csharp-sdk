// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryMigrateRegionListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The namespaces.</para>
        /// </summary>
        [NameInMap("RegionEntityList")]
        [Validation(Required=false)]
        public QueryMigrateRegionListResponseBodyRegionEntityList RegionEntityList { get; set; }
        public class QueryMigrateRegionListResponseBodyRegionEntityList : TeaModel {
            [NameInMap("RegionEntity")]
            [Validation(Required=false)]
            public List<QueryMigrateRegionListResponseBodyRegionEntityListRegionEntity> RegionEntity { get; set; }
            public class QueryMigrateRegionListResponseBodyRegionEntityListRegionEntity : TeaModel {
                /// <summary>
                /// <para>The name of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beta</para>
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// <para>The ID of the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing:beta</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-7ca7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
