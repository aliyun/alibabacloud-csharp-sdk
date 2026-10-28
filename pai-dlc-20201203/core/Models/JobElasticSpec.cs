// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobElasticSpec : TeaModel {
        /// <summary>
        /// <para>The AIMaster Docker image.</para>
        /// </summary>
        [NameInMap("AIMasterDockerImage")]
        [Validation(Required=false)]
        public string AIMasterDockerImage { get; set; }

        /// <summary>
        /// <para>The resource specifications for the AIMaster role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("AIMasterType")]
        [Validation(Required=false)]
        public string AIMasterType { get; set; }

        /// <summary>
        /// <para>The maximum EDP parallelism.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("EDPMaxParallelism")]
        [Validation(Required=false)]
        public int? EDPMaxParallelism { get; set; }

        /// <summary>
        /// <para>The minimum EDP parallelism.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("EDPMinParallelism")]
        [Validation(Required=false)]
        public int? EDPMinParallelism { get; set; }

        /// <summary>
        /// <para>The elastic training strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chief</para>
        /// </summary>
        [NameInMap("ElasticStrategy")]
        [Validation(Required=false)]
        public string ElasticStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable AIMaster.</para>
        /// </summary>
        [NameInMap("EnableAIMaster")]
        [Validation(Required=false)]
        public bool? EnableAIMaster { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable EDP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableEDP")]
        [Validation(Required=false)]
        public bool? EnableEDP { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable elastic training.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableElasticTraining")]
        [Validation(Required=false)]
        public bool? EnableElasticTraining { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the elastic PS feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnablePsJobElasticPS")]
        [Validation(Required=false)]
        public bool? EnablePsJobElasticPS { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable elastic workers for PS jobs.</para>
        /// </summary>
        [NameInMap("EnablePsJobElasticWorker")]
        [Validation(Required=false)]
        public bool? EnablePsJobElasticWorker { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable PS resource estimation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnablePsResourceEstimate")]
        [Validation(Required=false)]
        public bool? EnablePsResourceEstimate { get; set; }

        /// <summary>
        /// <para>The maximum parallelism.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MaxParallelism")]
        [Validation(Required=false)]
        public int? MaxParallelism { get; set; }

        /// <summary>
        /// <para>The minimum parallelism.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinParallelism")]
        [Validation(Required=false)]
        public int? MinParallelism { get; set; }

        /// <summary>
        /// <para>The maximum PS parallelism.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PSMaxParallelism")]
        [Validation(Required=false)]
        public int? PSMaxParallelism { get; set; }

        /// <summary>
        /// <para>The minimum PS parallelism.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("PSMinParallelism")]
        [Validation(Required=false)]
        public int? PSMinParallelism { get; set; }

    }

}
