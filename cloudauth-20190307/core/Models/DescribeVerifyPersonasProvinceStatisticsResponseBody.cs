// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyPersonasProvinceStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9821F95-CC18-5439-BB1C-21A0FF0C2003</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Query result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeVerifyPersonasProvinceStatisticsResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVerifyPersonasProvinceStatisticsResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Total number of devices.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("AllUserCnt")]
            [Validation(Required=false)]
            public long? AllUserCnt { get; set; }

            /// <summary>
            /// <para>Data items.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeVerifyPersonasProvinceStatisticsResponseBodyResultObjectItems> Items { get; set; }
            public class DescribeVerifyPersonasProvinceStatisticsResponseBodyResultObjectItems : TeaModel {
                /// <summary>
                /// <para>Total number of devices in the province.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ProvinceCnt")]
                [Validation(Required=false)]
                public long? ProvinceCnt { get; set; }

                /// <summary>
                /// <para>Province name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江</para>
                /// </summary>
                [NameInMap("ProvinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                /// <summary>
                /// <para>Percentage of the total for this province.</para>
                /// 
                /// <b>Example:</b>
                /// <para>35.71</para>
                /// </summary>
                [NameInMap("ProvinceRate")]
                [Validation(Required=false)]
                public string ProvinceRate { get; set; }

            }

        }

    }

}
