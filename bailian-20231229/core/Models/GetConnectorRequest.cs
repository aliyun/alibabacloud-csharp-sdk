// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetConnectorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the connector. You can find this ID in the <a href="https://bailian.console.aliyun.com/cn-beijing/?tab=app#/connector/list">Model Studio console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conn_file_xxxx</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The name of the connector to query. An exact match is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>连接器名称</para>
        /// </summary>
        [NameInMap("ConnectorName")]
        [Validation(Required=false)]
        public string ConnectorName { get; set; }

    }

}
