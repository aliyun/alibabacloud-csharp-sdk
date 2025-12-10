// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>EXECUTE_ALL</para>
        /// </summary>
        [NameInMap("ExecuteType")]
        [Validation(Required=false)]
        public string ExecuteType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>draft-o1p0k444nlq3cd50zz</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ExperimentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id-2d88-1608982098027-91558</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;mlflow&quot;:{&quot;experimentId&quot;:&quot;exp-1&quot;}}</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>draft-o1p0k444nlq3cd50zz</para>
        /// </summary>
        [NameInMap("PipelineDraftId")]
        [Validation(Required=false)]
        public string PipelineDraftId { get; set; }

    }

}
