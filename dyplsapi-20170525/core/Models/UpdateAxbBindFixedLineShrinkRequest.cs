// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class UpdateAxbBindFixedLineShrinkRequest : TeaModel {
        /// <summary>
        /// <para>主叫侧放音编码</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("Anucode")]
        [Validation(Required=false)]
        public string Anucode { get; set; }

        /// <summary>
        /// <para>被叫侧放音编码</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("Anucodecalled")]
        [Validation(Required=false)]
        public string Anucodecalled { get; set; }

        /// <summary>
        /// <para>号池ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALPT_1234</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>过期时间,单位：秒，必须为数字 0：不会自动解绑 非0：自动解绑周期</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
        /// <para>消息请求唯一标识。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
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
        /// <para>remark</para>
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
        /// <para>A100X558X0000400023</para>
        /// </summary>
        [NameInMap("SubId")]
        [Validation(Required=false)]
        public string SubId { get; set; }

        /// <summary>
        /// <para>格式为yyyyMMddHHmmss。时间采用北京时间，24小时制。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20150920190126</para>
        /// </summary>
        [NameInMap("Subts")]
        [Validation(Required=false)]
        public string Subts { get; set; }

        /// <summary>
        /// <para>接通后主叫侧的放音编码</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("TAnucodeConnect")]
        [Validation(Required=false)]
        public string TAnucodeConnect { get; set; }

        /// <summary>
        /// <para>真实号码，telA,telB不允许同时更新</para>
        /// 
        /// <b>Example:</b>
        /// <para>13900000000</para>
        /// </summary>
        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        /// <summary>
        /// <para>对端号码，telA,telB不允许同时更新</para>
        /// 
        /// <b>Example:</b>
        /// <para>13005711234</para>
        /// </summary>
        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

        /// <summary>
        /// <para>业务时间戳，格式yyyyMMddHHmmssSSS，时间采用北京时间，24小时制，精确至毫秒</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20161114143116001</para>
        /// </summary>
        [NameInMap("Ts")]
        [Validation(Required=false)]
        public string Ts { get; set; }

    }

}
