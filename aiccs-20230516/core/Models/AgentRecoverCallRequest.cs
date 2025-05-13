// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class AgentRecoverCallRequest : TeaModel {
        /// <summary>
        /// <para>坐席ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <para>坐席标签</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("AgentTag")]
        [Validation(Required=false)]
        public string AgentTag { get; set; }

        /// <summary>
        /// <para>查询开始导入时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-06 10:10:10</para>
        /// </summary>
        [NameInMap("BeginImportTime")]
        [Validation(Required=false)]
        public string BeginImportTime { get; set; }

        /// <summary>
        /// <para>查询结束导入时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-06 10:10:10</para>
        /// </summary>
        [NameInMap("EndImportTime")]
        [Validation(Required=false)]
        public string EndImportTime { get; set; }

        /// <summary>
        /// <para>号码列表</para>
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public List<string> Numbers { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>用户自定义标签列表</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
