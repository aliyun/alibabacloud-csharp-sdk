// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeLocationInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>340</para>
        /// </summary>
        [NameInMap("CnCount")]
        [Validation(Required=false)]
        public int? CnCount { get; set; }

        [NameInMap("CnList")]
        [Validation(Required=false)]
        public List<DescribeLocationInfoResponseBodyCnList> CnList { get; set; }
        public class DescribeLocationInfoResponseBodyCnList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3301</para>
            /// </summary>
            [NameInMap("LocId")]
            [Validation(Required=false)]
            public string LocId { get; set; }

            [NameInMap("LocName")]
            [Validation(Required=false)]
            public string LocName { get; set; }

        }

        [NameInMap("CnProvinceList")]
        [Validation(Required=false)]
        public List<DescribeLocationInfoResponseBodyCnProvinceList> CnProvinceList { get; set; }
        public class DescribeLocationInfoResponseBodyCnProvinceList : TeaModel {
            [NameInMap("Cities")]
            [Validation(Required=false)]
            public List<DescribeLocationInfoResponseBodyCnProvinceListCities> Cities { get; set; }
            public class DescribeLocationInfoResponseBodyCnProvinceListCities : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("LocId")]
                [Validation(Required=false)]
                public string LocId { get; set; }

                [NameInMap("LocName")]
                [Validation(Required=false)]
                public string LocName { get; set; }

            }

            [NameInMap("ProvinceName")]
            [Validation(Required=false)]
            public string ProvinceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>238</para>
        /// </summary>
        [NameInMap("OverseasCount")]
        [Validation(Required=false)]
        public int? OverseasCount { get; set; }

        [NameInMap("OverseasList")]
        [Validation(Required=false)]
        public List<DescribeLocationInfoResponseBodyOverseasList> OverseasList { get; set; }
        public class DescribeLocationInfoResponseBodyOverseasList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("LocId")]
            [Validation(Required=false)]
            public string LocId { get; set; }

            [NameInMap("LocName")]
            [Validation(Required=false)]
            public string LocName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CD3BE433-FAB0-55D8-918A-69B306****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
