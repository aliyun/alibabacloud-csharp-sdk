// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxb700Request : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7ee372834d2f4cc7ac0d0ab2d0ae1aac</para>
        /// </summary>
        [NameInMap("AsrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        /// &quot;ACallX_Apre&quot;:&quot;185&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Audio")]
        [Validation(Required=false)]
        public string Audio { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CONTROL_AX_DISABLE</para>
        /// </summary>
        [NameInMap("CallRestrict")]
        [Validation(Required=false)]
        public string CallRestrict { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CallTimeout")]
        [Validation(Required=false)]
        public long? CallTimeout { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;endCallIvrPhoneNo&quot;:&quot;A&quot;,
        ///     &quot;waitingDtmfTime&quot;:10,
        ///     &quot;maxLoop&quot;:3,
        ///     &quot;step1File&quot;:&quot;62ab72f8-4750-4234-859e-e8d678c0cad3-flow_tts_test_1.wav&quot;,
        ///     &quot;step2File&quot;:&quot;62ab72f8-4750-4234-859e-e8d678c0cad3-flow_tts_test_2.wav&quot;,
        ///     &quot;validKey&quot;:&quot;1,2&quot;,
        ///     &quot;waitingEndCall&quot;:2
        /// }</para>
        /// </summary>
        [NameInMap("DtmfConfig")]
        [Validation(Required=false)]
        public string DtmfConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-05 12:00:00</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>700.100.1/12345678</para>
        /// </summary>
        [NameInMap("IndustrialId")]
        [Validation(Required=false)]
        public string IndustrialId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedAsr")]
        [Validation(Required=false)]
        public bool? NeedAsr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedRecord")]
        [Validation(Required=false)]
        public bool? NeedRecord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abcdef</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abcdefgh</para>
        /// </summary>
        [NameInMap("OutOrderId")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC2258****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mp3</para>
        /// </summary>
        [NameInMap("RecType")]
        [Validation(Required=false)]
        public string RecType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139****0000</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>136****0000</para>
        /// </summary>
        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>700********0000</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

    }

}
