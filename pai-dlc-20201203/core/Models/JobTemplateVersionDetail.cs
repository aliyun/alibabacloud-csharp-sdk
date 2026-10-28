// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobTemplateVersionDetail : TeaModel {
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public Dictionary<string, string> Constraints { get; set; }

        /// <summary>
        /// <para>任务模板的配置内容，支持 CreateJob 接口的所有参数字段，以 JSON 对象存储</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>创建该版本的用户ID</para>
        /// </summary>
        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>该版本的创建时间</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>模板版本号</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
