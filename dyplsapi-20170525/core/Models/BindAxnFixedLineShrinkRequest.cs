// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxnFixedLineShrinkRequest : TeaModel {
        /// <summary>
        /// <para>放音编码必须包含3个场景的编码。按照“B-&gt;X,A-&gt;X,其他号码-&gt;X”的顺序填写编码，编码之间以逗号分隔。  比如：“1,2,3”表示B-&gt;X放音编号为1，A-&gt;X放音编号为2， 其他号码-&gt;X放音编号为3</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001,10002,10003</para>
        /// </summary>
        [NameInMap("Anucode")]
        [Validation(Required=false)]
        public string Anucode { get; set; }

        /// <summary>
        /// <para>被叫侧放音编码  被叫放音编码必须包含2个场景的编码。按照“A被叫,其他号码被叫”的顺序填写编码，编码之间以逗号分隔。  比如：“1,2”表示A号码为被叫侧接听时的放音编号为1，其他号码为被叫侧接听时的放音编号为2</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001,10002</para>
        /// </summary>
        [NameInMap("Anucodecalled")]
        [Validation(Required=false)]
        public string Anucodecalled { get; set; }

        /// <summary>
        /// <para>业务id标识，由阿里云分配给客户侧</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alitest</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>去掉“0” 例如：北京（10）；在平台分配X号码模式中，平台从号码池中分配该地区的X号码，避免产生呼叫长途费</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Areacode")]
        [Validation(Required=false)]
        public string Areacode { get; set; }

        /// <summary>
        /// <para>绑定类型，值如下： mode101：客户携带X号码 mode102：平台分配X号码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mode101</para>
        /// </summary>
        [NameInMap("BindType")]
        [Validation(Required=false)]
        public string BindType { get; set; }

        /// <summary>
        /// <para>位：秒，必须为数字 0：不会自动解绑 非0：自动解绑周期</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>扩展参数</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

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
        /// <para>接入商自有字段，最大100字符长度</para>
        /// 
        /// <b>Example:</b>
        /// <para>12444</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15500001111</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>N号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>15500002222</para>
        /// </summary>
        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

        /// <summary>
        /// <para>X号码； 平台分配号码模式下，该参数可不带，系统忽略该参数</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571409312</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

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
