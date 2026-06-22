// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetDataTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataTrendResponseBodyData Data { get; set; }
        public class GetDataTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of statistical timestamps for the trend data.</para>
            /// </summary>
            [NameInMap("DateList")]
            [Validation(Required=false)]
            public List<int?> DateList { get; set; }

            /// <summary>
            /// <para>The list of statistical date strings for the trend data.</para>
            /// </summary>
            [NameInMap("DateStrList")]
            [Validation(Required=false)]
            public List<string> DateStrList { get; set; }

            /// <summary>
            /// <para>The list of returned data.</para>
            /// </summary>
            [NameInMap("ItemList")]
            [Validation(Required=false)]
            public List<GetDataTrendResponseBodyDataItemList> ItemList { get; set; }
            public class GetDataTrendResponseBodyDataItemList : TeaModel {
                /// <summary>
                /// <para>The list of statistical values for the trend data.</para>
                /// </summary>
                [NameInMap("CountList")]
                [Validation(Required=false)]
                public List<long?> CountList { get; set; }

                /// <summary>
                /// <para>The type of security data. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>HC_NEW</b>: number of new baseline risks</description></item>
                /// <item><description><b>HC_OPERATE</b>: number of handled baseline risks</description></item>
                /// <item><description><b>VUL_NEW</b>: number of new vulnerability risks</description></item>
                /// <item><description><b>VUL_OPERATE</b>: number of handled vulnerability risks</description></item>
                /// <item><description><b>SUSP_NEW</b>: number of new alert risks</description></item>
                /// <item><description><b>SUSP_OPERATE</b>: number of handled alert risks.</description></item>
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
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1383B0DB-D5D6-4B0C-9E6B-75939C8E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
