// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDagsRequest : TeaModel {
        /// <summary>
        /// <para>The OpSeq. You can obtain this value from the response of CreateDagComplement. Before creating a data backfill task, you typically need to complete the business process, create files, and submit them. You can also obtain the DagId by calling RunCycleDagNodes, RunSmokeTest, or RunManualDagNodes, and then call GetDag to obtain the OpSeq.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("OpSeq")]
        [Validation(Required=false)]
        public long? OpSeq { get; set; }

        /// <summary>
        /// <para>The identity of the scheduling and O&amp;M environment. PROD indicates the production environment, and DEV indicates the development environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
