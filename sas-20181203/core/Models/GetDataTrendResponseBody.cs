// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDataTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataTrendResponseBodyData Data { get; set; }
        public class GetDataTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The statistical timestamps of the trend data.</para>
            /// </summary>
            [NameInMap("DateList")]
            [Validation(Required=false)]
            public List<int?> DateList { get; set; }

            /// <summary>
            /// <para>The statistical dates and time for the trend data.</para>
            /// </summary>
            [NameInMap("DateStrList")]
            [Validation(Required=false)]
            public List<string> DateStrList { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("ItemList")]
            [Validation(Required=false)]
            public List<GetDataTrendResponseBodyDataItemList> ItemList { get; set; }
            public class GetDataTrendResponseBodyDataItemList : TeaModel {
                /// <summary>
                /// <para>The statistical values of the trend data.</para>
                /// </summary>
                [NameInMap("CountList")]
                [Validation(Required=false)]
                public List<long?> CountList { get; set; }

                /// <summary>
                /// <para>The type of the security data. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>HC_NEW</b>: the number of new baseline risks.</description></item>
                /// <item><description><b>HC_OPERATE</b>: the number of handled baseline risks.</description></item>
                /// <item><description><b>VUL_NEW</b>: the number of new vulnerabilities.</description></item>
                /// <item><description><b>VUL_OPERATE</b>: the number of handled vulnerabilities.</description></item>
                /// <item><description><b>SUSP_NEW</b>: the number of new alerts.</description></item>
                /// <item><description><b>SUSP_OPERATE</b>: the number of handled alerts.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HC_NEW</para>
                /// </summary>
                [NameInMap("KeyName")]
                [Validation(Required=false)]
                public string KeyName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1383B0DB-D5D6-4B0C-9E6B-75939C8E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
