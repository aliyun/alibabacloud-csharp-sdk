// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetSaleDistrictResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned service code. A value of 0 indicates that the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the ISPs in the area.</para>
        /// </summary>
        [NameInMap("EnsNetDistricts")]
        [Validation(Required=false)]
        public DescribeEnsNetSaleDistrictResponseBodyEnsNetDistricts EnsNetDistricts { get; set; }
        public class DescribeEnsNetSaleDistrictResponseBodyEnsNetDistricts : TeaModel {
            [NameInMap("EnsNetDistrict")]
            [Validation(Required=false)]
            public List<DescribeEnsNetSaleDistrictResponseBodyEnsNetDistrictsEnsNetDistrict> EnsNetDistrict { get; set; }
            public class DescribeEnsNetSaleDistrictResponseBodyEnsNetDistrictsEnsNetDistrict : TeaModel {
                /// <summary>
                /// <para>The information about the ISP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{                         &quot;count&quot;:2,                         &quot;name&quot;:&quot;telecommunication&quot;,                         &quot;code&quot;:&quot;telecom&quot;,                         &quot;country&quot;:&quot;cn&quot;                     }</para>
                /// </summary>
                [NameInMap("EnsRegionIdCount")]
                [Validation(Required=false)]
                public string EnsRegionIdCount { get; set; }

                /// <summary>
                /// <para>The information about the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{                         &quot;count&quot;:2,                         &quot;code&quot;:&quot;multiCarrier&quot;                     }</para>
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public string InstanceCount { get; set; }

                /// <summary>
                /// <para>The region code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100101</para>
                /// </summary>
                [NameInMap("NetDistrictCode")]
                [Validation(Required=false)]
                public string NetDistrictCode { get; set; }

                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>northEast</para>
                /// </summary>
                [NameInMap("NetDistrictEnName")]
                [Validation(Required=false)]
                public string NetDistrictEnName { get; set; }

                /// <summary>
                /// <para>The parent code of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("NetDistrictFatherCode")]
                [Validation(Required=false)]
                public string NetDistrictFatherCode { get; set; }

                /// <summary>
                /// <para>The region level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Big</b>: area</description></item>
                /// <item><description><b>Middle</b>: province</description></item>
                /// <item><description><b>Small</b>: city</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Big</para>
                /// </summary>
                [NameInMap("NetDistrictLevel")]
                [Validation(Required=false)]
                public string NetDistrictLevel { get; set; }

                /// <summary>
                /// <para>The Chinese name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Northeast China</para>
                /// </summary>
                [NameInMap("NetDistrictName")]
                [Validation(Required=false)]
                public string NetDistrictName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1707B55C-A12F-43EF-BC66-14FFDB9253C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
