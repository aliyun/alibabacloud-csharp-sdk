// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetContextLogsRequest : TeaModel {
        /// <summary>
        /// <para>The number of logs that you want to obtain and are generated before the generation time of the start log. Valid values: <c>(0,100]</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("back_lines")]
        [Validation(Required=false)]
        public long? BackLines { get; set; }

        /// <summary>
        /// <para>The number of logs that you want to obtain and are generated after the generation time of the start log. Valid values: <c>(0,100]</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("forward_lines")]
        [Validation(Required=false)]
        public long? ForwardLines { get; set; }

        /// <summary>
        /// <para>The unique identifier of the log group to which the start log belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85C897C740352DC6-808</para>
        /// </summary>
        [NameInMap("pack_id")]
        [Validation(Required=false)]
        public string PackId { get; set; }

        /// <summary>
        /// <para>The unique context identifier of the start log in the log group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2|MTY1NTcwNTUzODY5MTY0MDk1Mg==|3|0</para>
        /// </summary>
        [NameInMap("pack_meta")]
        [Validation(Required=false)]
        public string PackMeta { get; set; }

    }

}
