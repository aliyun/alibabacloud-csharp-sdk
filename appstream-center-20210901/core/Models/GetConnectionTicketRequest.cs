// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetConnectionTicketRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ca-e4s0puhmwi7v****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppInstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ai-1rznfnrvsa99d****</para>
        /// </summary>
        [NameInMap("AppInstanceId")]
        [Validation(Required=false)]
        public string AppInstanceId { get; set; }

        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/q /n</para>
        /// </summary>
        [NameInMap("AppStartParam")]
        [Validation(Required=false)]
        public string AppStartParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>28778acb-a469-4bc0-8e0f****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
