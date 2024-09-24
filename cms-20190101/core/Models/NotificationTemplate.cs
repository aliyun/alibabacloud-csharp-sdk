// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class NotificationTemplate : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Alarm $.alertName</para>
        /// </summary>
        [NameInMap("EnContent")]
        [Validation(Required=false)]
        public string EnContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Alarm $.alertName</para>
        /// </summary>
        [NameInMap("EnItemContent")]
        [Validation(Required=false)]
        public string EnItemContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Alarm $.alertName</para>
        /// </summary>
        [NameInMap("EnTitle")]
        [Validation(Required=false)]
        public string EnTitle { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DATA,  SMS,  ONCALL,  MAIL,  DING,  WEIXIN,  FEISHU,  SLACK</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TEXT, MARKDOWN,CARD</para>
        /// </summary>
        [NameInMap("WraperType")]
        [Validation(Required=false)]
        public string WraperType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>报警 $.alertName</para>
        /// </summary>
        [NameInMap("ZhContent")]
        [Validation(Required=false)]
        public string ZhContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>报警 $.alertName</para>
        /// </summary>
        [NameInMap("ZhItemContent")]
        [Validation(Required=false)]
        public string ZhItemContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>报警通知 $.alertName</para>
        /// </summary>
        [NameInMap("ZhTitle")]
        [Validation(Required=false)]
        public string ZhTitle { get; set; }

    }

}
