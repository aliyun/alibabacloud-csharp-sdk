// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryAxbBindFixedLineRequest : TeaModel {
        /// <summary>
        /// <para>应用id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALPT_1234</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>业务id，消息请求标识</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ererrrdrrrr</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>A/B号码，queryType=1时，必传</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>查询类型 0：根据绑定id查询 1：根据X和A/B号码查询</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>绑定id， queryType=0时，必传</para>
        /// 
        /// <b>Example:</b>
        /// <para>A20304o0200303004j</para>
        /// </summary>
        [NameInMap("SubId")]
        [Validation(Required=false)]
        public string SubId { get; set; }

        /// <summary>
        /// <para>x号码，queryType=1时，必传</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

        /// <summary>
        /// <para>格式yyyyMMddHHmmssSSS，时间采用北京时间，24小时制，精确至毫秒</para>
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
