// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobElasticSpec : TeaModel {
        [NameInMap("AIMasterDockerImage")]
        [Validation(Required=false)]
        public string AIMasterDockerImage { get; set; }

        [NameInMap("AIMasterType")]
        [Validation(Required=false)]
        public string AIMasterType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("EDPMaxParallelism")]
        [Validation(Required=false)]
        public int? EDPMaxParallelism { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("EDPMinParallelism")]
        [Validation(Required=false)]
        public int? EDPMinParallelism { get; set; }

        [NameInMap("ElasticStrategy")]
        [Validation(Required=false)]
        public string ElasticStrategy { get; set; }

        [NameInMap("EnableAIMaster")]
        [Validation(Required=false)]
        public bool? EnableAIMaster { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableEDP")]
        [Validation(Required=false)]
        public bool? EnableEDP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableElasticTraining")]
        [Validation(Required=false)]
        public bool? EnableElasticTraining { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnablePsJobElasticPS")]
        [Validation(Required=false)]
        public bool? EnablePsJobElasticPS { get; set; }

        [NameInMap("EnablePsJobElasticWorker")]
        [Validation(Required=false)]
        public bool? EnablePsJobElasticWorker { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnablePsResourceEstimate")]
        [Validation(Required=false)]
        public bool? EnablePsResourceEstimate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MaxParallelism")]
        [Validation(Required=false)]
        public int? MaxParallelism { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinParallelism")]
        [Validation(Required=false)]
        public int? MinParallelism { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PSMaxParallelism")]
        [Validation(Required=false)]
        public int? PSMaxParallelism { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("PSMinParallelism")]
        [Validation(Required=false)]
        public int? PSMinParallelism { get; set; }

    }

}
