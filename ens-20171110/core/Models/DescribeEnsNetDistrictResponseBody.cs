// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsNetDistrictResponseBody : TeaModel {
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
        /// <para>The information about the regions.</para>
        /// </summary>
        [NameInMap("EnsNetDistricts")]
        [Validation(Required=false)]
        public DescribeEnsNetDistrictResponseBodyEnsNetDistricts EnsNetDistricts { get; set; }
        public class DescribeEnsNetDistrictResponseBodyEnsNetDistricts : TeaModel {
            [NameInMap("EnsNetDistrict")]
            [Validation(Required=false)]
            public List<DescribeEnsNetDistrictResponseBodyEnsNetDistrictsEnsNetDistrict> EnsNetDistrict { get; set; }
            public class DescribeEnsNetDistrictResponseBodyEnsNetDistrictsEnsNetDistrict : TeaModel {
                /// <summary>
                /// <para>The number of nodes in the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("EnsRegionIdCount")]
                [Validation(Required=false)]
                public string EnsRegionIdCount { get; set; }

                /// <summary>
                /// <para>The code of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100106</para>
                /// </summary>
                [NameInMap("NetDistrictCode")]
                [Validation(Required=false)]
                public string NetDistrictCode { get; set; }

                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>southWest</para>
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
                /// <para>The level of the region.</para>
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
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>southwest China</para>
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
        /// <para>F3B261DD-3858-4D3C-877D-303ADF374600</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
