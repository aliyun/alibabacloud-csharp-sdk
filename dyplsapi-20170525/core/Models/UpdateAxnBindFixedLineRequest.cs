// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UpdateAxnBindFixedLineRequest : TeaModel {
        /// <summary>
        /// <para>放音编码必须包含3个场景的编码。按照“B-&gt;X,A-&gt;X,其他号码-&gt;X”的顺序填写编码，编码之间以逗号分隔。  比如：“1,2,3”表示B-&gt;X放音编号为1，A-&gt;X放音编号为2， 其他号码-&gt;X放音编号为3。</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Anucode")]
        [Validation(Required=false)]
        public string Anucode { get; set; }

        /// <summary>
        /// <para>被叫侧放音编码  被叫放音编码必须包含2个场景的编码。按照“A被叫,其他号码被叫”的顺序填写编码，编码之间以逗号分隔。  比如：“1,2”表示A号码为被叫侧接听时的放音编号为1，其他号码为被叫侧接听时的放音编号为2。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001,10002</para>
        /// </summary>
        [NameInMap("Anucodecalled")]
        [Validation(Required=false)]
        public string Anucodecalled { get; set; }

        /// <summary>
        /// <para>号池ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alitest</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>位：秒，必须为数字 0：不会自动解绑 非0：自动解绑周期</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>额外字段</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public UpdateAxnBindFixedLineRequestExtra Extra { get; set; }
        public class UpdateAxnBindFixedLineRequestExtra : TeaModel {
            /// <summary>
            /// <para>A通过X呼叫，即A主叫X，仅下列值有效。默认是0。 0：不能外呼 1：接续最近的N号码 2：回拨固定号码：telB</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Callback")]
            [Validation(Required=false)]
            public string Callback { get; set; }

            /// <summary>
            /// <para>录音控制，仅下列值有效。默认是0（不开通录音功能）。 0：不录音 1：录音</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Callrecording")]
            [Validation(Required=false)]
            public string Callrecording { get; set; }

        }

        /// <summary>
        /// <para>消息请求唯一标识</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345dkwkd99d</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>接入商自有字段，最大250字符长度</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>绑定id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GHX0534X202504221531579290029-2-1-aliaxn</para>
        /// </summary>
        [NameInMap("SubId")]
        [Validation(Required=false)]
        public string SubId { get; set; }

        /// <summary>
        /// <para>格式为yyyyMMddHHmmss。时间采用北京时间，24小时制。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250421141723098</para>
        /// </summary>
        [NameInMap("Subts")]
        [Validation(Required=false)]
        public string Subts { get; set; }

        /// <summary>
        /// <para>接通后主叫侧放音编码  接通后主叫侧放音编码必须包含2个场景的编码。按照“A被叫,其他号码被叫”的顺序填写编码，编码之间以逗号分隔。  比如：“1,2”表示A号码为被叫时主叫侧的放音编号为1，其他号码被叫为被叫时主叫侧的放音编号为2</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001,10002</para>
        /// </summary>
        [NameInMap("TAnucodeConnect")]
        [Validation(Required=false)]
        public string TAnucodeConnect { get; set; }

        /// <summary>
        /// <para>A号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>15500001111</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>B号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>15500002222</para>
        /// </summary>
        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

        /// <summary>
        /// <para>格式yyyyMMddHHmmssSSS，时间采用北京时间，24小时制，精确至毫秒</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250421141723098</para>
        /// </summary>
        [NameInMap("Ts")]
        [Validation(Required=false)]
        public string Ts { get; set; }

    }

}
