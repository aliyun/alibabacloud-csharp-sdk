// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class CreateTaskOrderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("IsUrgent")]
        [Validation(Required=false)]
        public bool? IsUrgent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cid+lUpHxTIXt7DYqJDcpVxlA==</para>
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任务单标题：必填</para>
        /// </summary>
        [NameInMap("Overview")]
        [Validation(Required=false)]
        public string Overview { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>重要性描述</para>
        /// </summary>
        [NameInMap("UrgentDescription")]
        [Validation(Required=false)]
        public string UrgentDescription { get; set; }

    }

}
