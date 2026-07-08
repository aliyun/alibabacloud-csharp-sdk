// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class GetUAIDApplyTokenSignRequest : TeaModel {
        /// <summary>
        /// <para>The authorization code.</para>
        /// <remarks>
        /// <para>To obtain this authorization code, navigate to <b>Tag Plaza</b> in the <a href="https://dytns.console.aliyun.com/analysis/square"><b>Phone Number Verification Service</b></a> console, select a tag, and submit an application. You receive the code after your application is approved.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HwD97InG</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The mobile carrier. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CM</b>: China Mobile</para>
        /// </description></item>
        /// <item><description><para><b>CU</b>: China Unicom</para>
        /// </description></item>
        /// <item><description><para><b>CT</b>: China Telecom</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CM</para>
        /// </summary>
        [NameInMap("Carrier")]
        [Validation(Required=false)]
        public string Carrier { get; set; }

        /// <summary>
        /// <para>The client type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>30100</c>: Android</para>
        /// </description></item>
        /// <item><description><para><c>30300</c>: iOS</para>
        /// </description></item>
        /// <item><description><para><c>20200</c>: H5</para>
        /// </description></item>
        /// <item><description><para><c>10010</c>: Web</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30300</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>The external ID.</para>
        /// <remarks>
        /// <para>For China Mobile (CM), this parameter corresponds to <c>traceId</c> and <c>msgId</c>. The values of <c>OutId</c>, <c>traceId</c>, and <c>msgId</c> must be the same.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b8b5b3a*******0b9893484fdf412c99</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required if the carrier is China Telecom (CT). For details, see the China Telecom documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>955EC1A869852EA8BC66F********D7C6E92017BBD5B001C736EFEAFB775C232</para>
        /// </summary>
        [NameInMap("ParamKey")]
        [Validation(Required=false)]
        public string ParamKey { get; set; }

        /// <summary>
        /// <para>This parameter is required if the carrier is China Telecom (CT). For details, see the China Telecom documentation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2F0D4CD7A216D16CE2AF4BBC********29A454FDDD991F919106C12CB89ABA8</para>
        /// </summary>
        [NameInMap("ParamStr")]
        [Validation(Required=false)]
        public string ParamStr { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The event timestamp, accurate to the millisecond.<br>
        /// Format: <c>yyyyMMddHHmmssSSS</c>.<br></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20121227180001165</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
