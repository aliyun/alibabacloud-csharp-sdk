// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E27D502-1287-526A-910C-881A3F023914</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public DescribeVerifyStatisticsResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVerifyStatisticsResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The number of client-side init attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73</para>
            /// </summary>
            [NameInMap("InitDevice")]
            [Validation(Required=false)]
            public long? InitDevice { get; set; }

            /// <summary>
            /// <para>The number of identity deduplication client-side init requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("InitDeviceId")]
            [Validation(Required=false)]
            public long? InitDeviceId { get; set; }

            /// <summary>
            /// <para>The number of successful identity deduplication client-side init requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("InitDeviceIdSuccess")]
            [Validation(Required=false)]
            public long? InitDeviceIdSuccess { get; set; }

            /// <summary>
            /// <para>The number of client-side init calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73</para>
            /// </summary>
            [NameInMap("InitDeviceSuccess")]
            [Validation(Required=false)]
            public long? InitDeviceSuccess { get; set; }

            /// <summary>
            /// <para>The number of server-side init attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73</para>
            /// </summary>
            [NameInMap("InitService")]
            [Validation(Required=false)]
            public long? InitService { get; set; }

            /// <summary>
            /// <para>The total number of identity deduplication server-side init requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("InitServiceId")]
            [Validation(Required=false)]
            public long? InitServiceId { get; set; }

            /// <summary>
            /// <para>The number of successful identity deduplication server-side init requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("InitServiceIdSuccess")]
            [Validation(Required=false)]
            public long? InitServiceIdSuccess { get; set; }

            /// <summary>
            /// <para>The number of successful server-side init authentications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>134</para>
            /// </summary>
            [NameInMap("InitServiceSuccess")]
            [Validation(Required=false)]
            public long? InitServiceSuccess { get; set; }

            /// <summary>
            /// <para>The daily pass rate and conversion rate statistics (PV).</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeVerifyStatisticsResponseBodyResultObjectItems> Items { get; set; }
            public class DescribeVerifyStatisticsResponseBodyResultObjectItems : TeaModel {
                /// <summary>
                /// <para>The date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-11</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>The client-side init pass rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("InitDevicePassRate")]
                [Validation(Required=false)]
                public string InitDevicePassRate { get; set; }

                /// <summary>
                /// <para>The number of server-side init requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("InitService")]
                [Validation(Required=false)]
                public long? InitService { get; set; }

                /// <summary>
                /// <para>The server-side init conversion rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26.67</para>
                /// </summary>
                [NameInMap("InitServiceConversionRate")]
                [Validation(Required=false)]
                public string InitServiceConversionRate { get; set; }

                /// <summary>
                /// <para>The server-side init pass rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("InitServicePassRate")]
                [Validation(Required=false)]
                public string InitServicePassRate { get; set; }

                /// <summary>
                /// <para>The pass rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>75</para>
                /// </summary>
                [NameInMap("PassRate")]
                [Validation(Required=false)]
                public string PassRate { get; set; }

            }

            /// <summary>
            /// <para>The number of client-side verification attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("VerifyDevice")]
            [Validation(Required=false)]
            public long? VerifyDevice { get; set; }

            /// <summary>
            /// <para>The number of identity deduplication client-side authentication attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("VerifyDeviceId")]
            [Validation(Required=false)]
            public long? VerifyDeviceId { get; set; }

            /// <summary>
            /// <para>The number of successful identity deduplication client-side verifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("VerifyDeviceIdSuccess")]
            [Validation(Required=false)]
            public long? VerifyDeviceIdSuccess { get; set; }

            /// <summary>
            /// <para>The number of successful identity deduplication client-side authentications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("VerifyDeviceIdSuccessPassed")]
            [Validation(Required=false)]
            public long? VerifyDeviceIdSuccessPassed { get; set; }

            /// <summary>
            /// <para>The number of successful client-side authentications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("VerifyDeviceSuccess")]
            [Validation(Required=false)]
            public long? VerifyDeviceSuccess { get; set; }

            /// <summary>
            /// <para>The number of successful client-side authentications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("VerifyDeviceSuccessPassed")]
            [Validation(Required=false)]
            public long? VerifyDeviceSuccessPassed { get; set; }

        }

    }

}
