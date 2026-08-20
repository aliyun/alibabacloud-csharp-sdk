// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TicketPageQueryScenicResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TicketPageQueryScenicResponseBodyData Data { get; set; }
        public class TicketPageQueryScenicResponseBodyData : TeaModel {
            [NameInMap("Scenics")]
            [Validation(Required=false)]
            public List<TicketPageQueryScenicResponseBodyDataScenics> Scenics { get; set; }
            public class TicketPageQueryScenicResponseBodyDataScenics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>杭州市西湖区龙井路1号</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>杭州市</para>
                /// </summary>
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>中国</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>国家5A级旅游景区</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;<a href="https://example.com/img1.jpg%22%5D">https://example.com/img1.jpg&quot;]</a></para>
                /// </summary>
                [NameInMap("Images")]
                [Validation(Required=false)]
                public List<string> Images { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>31.138026</para>
                /// </summary>
                [NameInMap("Latitude")]
                [Validation(Required=false)]
                public double? Latitude { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AAAAA</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>121.658793</para>
                /// </summary>
                [NameInMap("Longitude")]
                [Validation(Required=false)]
                public double? Longitude { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>西湖风景区</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>08:00-17:30</para>
                /// </summary>
                [NameInMap("OpeningTime")]
                [Validation(Required=false)]
                public string OpeningTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0571-12345678</para>
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;type&quot;:&quot;儿童&quot;,&quot;typeDesc&quot;:&quot;3周岁(含)至11周岁(含)享受优惠票&quot;},{&quot;type&quot;:&quot;老年人&quot;,&quot;typeDesc&quot;:&quot;65周岁(含)以上享受优惠票&quot;}]</para>
                /// </summary>
                [NameInMap("PreferentialPolicy")]
                [Validation(Required=false)]
                public string PreferentialPolicy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>浙江省</para>
                /// </summary>
                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1天</para>
                /// </summary>
                [NameInMap("ResidenceTime")]
                [Validation(Required=false)]
                public string ResidenceTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("ScenicId")]
                [Validation(Required=false)]
                public long? ScenicId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ScenicIdInvalid</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ScenicId不合法</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>51593418-8C73-5E47-8BA8-3F1D4A00CC0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
