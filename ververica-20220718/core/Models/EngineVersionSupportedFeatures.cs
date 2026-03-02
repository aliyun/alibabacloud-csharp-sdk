// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class EngineVersionSupportedFeatures : TeaModel {
        /// <summary>
        /// <para>Specifies whether the engine version can be used to create a native savepoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("supportNativeSavepoint")]
        [Validation(Required=false)]
        public bool? SupportNativeSavepoint { get; set; }

        /// <summary>
        /// <para>Specifies whether the engine version can be used to submit an SQL deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("useForSqlDeployments")]
        [Validation(Required=false)]
        public bool? UseForSqlDeployments { get; set; }

    }

}
