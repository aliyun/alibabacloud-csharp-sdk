// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveCenterTransferResponseBody : TeaModel {
        /// <summary>
        /// <para>The stream relay information.</para>
        /// </summary>
        [NameInMap("LiveCenterTransferInfoList")]
        [Validation(Required=false)]
        public DescribeLiveCenterTransferResponseBodyLiveCenterTransferInfoList LiveCenterTransferInfoList { get; set; }
        public class DescribeLiveCenterTransferResponseBodyLiveCenterTransferInfoList : TeaModel {
            [NameInMap("LiveCenterTransferInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveCenterTransferResponseBodyLiveCenterTransferInfoListLiveCenterTransferInfo> LiveCenterTransferInfo { get; set; }
            public class DescribeLiveCenterTransferResponseBodyLiveCenterTransferInfoListLiveCenterTransferInfo : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>teststream</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The third-party URL to which the live stream is relayed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://push.example2.aliyunlive.com/testapp1/teststream2</para>
                /// </summary>
                [NameInMap("DstUrl")]
                [Validation(Required=false)]
                public string DstUrl { get; set; }

                /// <summary>
                /// <para>The end time of stream relay.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-29T15:16:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The start time of stream relay.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-28T15:16:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>teststream</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The validity period of stream relay. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>always</b>: The stream can always be relayed.</description></item>
                /// <item><description><b>time</b>: The stream can be relayed in a specified time period.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>time</para>
                /// </summary>
                [NameInMap("TransferArgs")]
                [Validation(Required=false)]
                public string TransferArgs { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4865B85-664B-19D3-BB16-C62FB83C8226</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
