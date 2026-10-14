// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetConnectorClientRequest : TeaModel {
        /// <summary>
        /// <para>The connector ID. You can obtain this value from the <a href="~~ListConnectors~~">ListConnectors</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-94db94e06b98****</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the ConnectorClient device. You can obtain this value from the <a href="~~ListConnectors~~">ListConnectors</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4BD65C4-58F6-5127-AD2F-319CF020F549</para>
        /// </summary>
        [NameInMap("DevTag")]
        [Validation(Required=false)]
        public string DevTag { get; set; }

    }

}
