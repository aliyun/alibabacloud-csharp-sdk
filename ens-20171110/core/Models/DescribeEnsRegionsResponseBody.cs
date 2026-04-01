// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The service code. 0 is returned for a successful request. An error code is returned for a failed request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EnsRegions")]
        [Validation(Required=false)]
        public DescribeEnsRegionsResponseBodyEnsRegions EnsRegions { get; set; }
        public class DescribeEnsRegionsResponseBodyEnsRegions : TeaModel {
            [NameInMap("EnsRegions")]
            [Validation(Required=false)]
            public List<DescribeEnsRegionsResponseBodyEnsRegionsEnsRegions> EnsRegions { get; set; }
            public class DescribeEnsRegionsResponseBodyEnsRegionsEnsRegions : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                [NameInMap("EnName")]
                [Validation(Required=false)]
                public string EnName { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
