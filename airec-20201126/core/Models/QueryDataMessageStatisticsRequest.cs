// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class QueryDataMessageStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The type of behaviors. Valid values: expose, click, like, comment, collect, stay, cart, buy, and evaluate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>expose</para>
        /// </summary>
        [NameInMap("bhvType")]
        [Validation(Required=false)]
        public string BhvType { get; set; }

        /// <summary>
        /// <para>The type of the operation. Valid values: update, delete, and add.</para>
        /// 
        /// <b>Example:</b>
        /// <para>update</para>
        /// </summary>
        [NameInMap("cmdType")]
        [Validation(Required=false)]
        public string CmdType { get; set; }

        /// <summary>
        /// <para>The end time. The value is a timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1586673466</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("imei")]
        [Validation(Required=false)]
        public string Imei { get; set; }

        /// <summary>
        /// <para>The ID of the item. This parameter is required when the value of table is set to item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("itemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// <para>The type of the item. This parameter is required when the value of table is set to item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// <para>The source of the operation. Valid values:</para>
        /// <para>CONSOLE and FEEDER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEEDER</para>
        /// </summary>
        [NameInMap("messageSource")]
        [Validation(Required=false)]
        public string MessageSource { get; set; }

        /// <summary>
        /// <para>The scene ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("sceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para>The start time. The value is a timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1586673466</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The event tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

        /// <summary>
        /// <para>The ID of the user. This parameter is required when the value of table is set to user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>222</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The type of the user. This parameter is required when the value of table is set to user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("userType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
