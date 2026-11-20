// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class ListXTelephonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denied error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0000: Success.</para>
        /// </description></item>
        /// <item><description><para>Other values: Failure.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data collection.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListXTelephonesResponseBodyData Data { get; set; }
        public class ListXTelephonesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListXTelephonesResponseBodyDataList> List { get; set; }
            public class ListXTelephonesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The reason for binding failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Binding failed: user ID card blacklisted</para>
                /// </summary>
                [NameInMap("AuthMsg")]
                [Validation(Required=false)]
                public string AuthMsg { get; set; }

                /// <summary>
                /// <para>The binding time. The format is YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-29 17:23:58</para>
                /// </summary>
                [NameInMap("BindTime")]
                [Validation(Required=false)]
                public string BindTime { get; set; }

                /// <summary>
                /// <para>The purchase time. The format is YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-29 17:23:58</para>
                /// </summary>
                [NameInMap("BuyTime")]
                [Validation(Required=false)]
                public string BuyTime { get; set; }

                /// <summary>
                /// <para>The customer number pool key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FC533e6eeb81f4400c87ef3745a21a1a</para>
                /// </summary>
                [NameInMap("CustomerPoolKey")]
                [Validation(Required=false)]
                public string CustomerPoolKey { get; set; }

                /// <summary>
                /// <para>The number pool name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test number pool</para>
                /// </summary>
                [NameInMap("CustomerPoolName")]
                [Validation(Required=false)]
                public string CustomerPoolName { get; set; }

                /// <summary>
                /// <para>The release time. The format is YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-29 17:23:58</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// <para>The SMS activation status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Not activated.</description></item>
                /// <item><description>1: Activated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SmsStatus")]
                [Validation(Required=false)]
                public string SmsStatus { get; set; }

                /// <summary>
                /// <para>The X number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17816876546</para>
                /// </summary>
                [NameInMap("Telephone")]
                [Validation(Required=false)]
                public string Telephone { get; set; }

                /// <summary>
                /// <para>The number status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Idle.</description></item>
                /// <item><description>1: Allocation completed and pending purchase.</description></item>
                /// <item><description>2: Purchase completed and pending verification.</description></item>
                /// <item><description>3: Real-name verification in progress.</description></item>
                /// <item><description>4: Real-name verification succeeded.</description></item>
                /// <item><description>5: Verification failed.</description></item>
                /// <item><description>6: Unbinding in progress.</description></item>
                /// <item><description>7: Unbinding failed.</description></item>
                /// <item><description>8: Released.</description></item>
                /// <item><description>99: Released due to timeout.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TelephoneStatus")]
                [Validation(Required=false)]
                public string TelephoneStatus { get; set; }

                /// <summary>
                /// <para>The unbinding time. The format is YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-29 17:23:58</para>
                /// </summary>
                [NameInMap("UnbindTime")]
                [Validation(Required=false)]
                public string UnbindTime { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries that meet the query conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Success.</para>
        /// </description></item>
        /// <item><description><para>false: Failure.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
