// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateQualityFollowerRequest : TeaModel {
        /// <summary>
        /// <para>The notification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: email.</description></item>
        /// <item><description>2: email and text message.</description></item>
        /// <item><description>4: DingTalk chatbot.</description></item>
        /// <item><description>5: DingTalk chatbot @ALL.</description></item>
        /// <item><description>6: Lark.</description></item>
        /// <item><description>7: WeCom.</description></item>
        /// <item><description>8: WEBHOOK.</description></item>
        /// <item><description>9: phone call alert.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AlarmMode")]
        [Validation(Required=false)]
        public int? AlarmMode { get; set; }

        /// <summary>
        /// <para>The ID of the partition expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// <para>The account ID of the subscriber.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Follower")]
        [Validation(Required=false)]
        public string Follower { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can obtain the ID from the DataWorks console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the engine or data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
