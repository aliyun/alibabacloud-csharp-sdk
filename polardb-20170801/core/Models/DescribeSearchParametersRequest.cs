// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSearchParametersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB primary cluster. This ID is used to locate the Search cluster associated with the current account. Only PolarDB for MySQL clusters are supported. Search is not supported for PostgreSQL or Oracle-compatible clusters. Before you call this operation, enable the Search engine for the target cluster in the PolarDB console. If the Search engine is not enabled, the InvalidDBClusterId.NotFound error may be returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxxxxxxx</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

    }

}
