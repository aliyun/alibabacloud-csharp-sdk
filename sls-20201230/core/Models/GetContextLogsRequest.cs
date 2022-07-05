// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetContextLogsRequest : TeaModel {
        /// <summary>
        /// 指定起始日志往前（上文）的日志条数，取值范围为(0,100]。
        /// </summary>
        [NameInMap("back_lines")]
        [Validation(Required=false)]
        public long? BackLines { get; set; }

        /// <summary>
        /// 指定起始日志往后（下文）的日志条数，取值范围为(0,100]。
        /// </summary>
        [NameInMap("forward_lines")]
        [Validation(Required=false)]
        public long? ForwardLines { get; set; }

        /// <summary>
        /// 起始日志所属的LogGroup的唯一身份标识。
        /// </summary>
        [NameInMap("pack_id")]
        [Validation(Required=false)]
        public string PackId { get; set; }

        /// <summary>
        /// 起始日志在对应LogGroup内的唯一上下文结构标识。
        /// </summary>
        [NameInMap("pack_meta")]
        [Validation(Required=false)]
        public string PackMeta { get; set; }

        /// <summary>
        /// Logstore中数据的类型。该接口中该参数固定为context_log。
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
