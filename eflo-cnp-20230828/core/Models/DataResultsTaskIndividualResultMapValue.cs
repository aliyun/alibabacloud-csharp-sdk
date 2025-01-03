// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class DataResultsTaskIndividualResultMapValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>54</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public long? ExperimentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>p-jt-waf-app1</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fluxserv-6fc89b45cf-w8wq6</para>
        /// </summary>
        [NameInMap("PodName")]
        [Validation(Required=false)]
        public string PodName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("GpuNum")]
        [Validation(Required=false)]
        public int? GpuNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8x OAM 810 GPU</para>
        /// </summary>
        [NameInMap("GpuName")]
        [Validation(Required=false)]
        public string GpuName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WarningFlag")]
        [Validation(Required=false)]
        public bool? WarningFlag { get; set; }

        [NameInMap("WarningMsg")]
        [Validation(Required=false)]
        public string WarningMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ErrorFlag")]
        [Validation(Required=false)]
        public bool? ErrorFlag { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>TFLOPS</para>
        /// 
        /// <b>Example:</b>
        /// <para>45</para>
        /// </summary>
        [NameInMap("Tflops")]
        [Validation(Required=false)]
        public double? Tflops { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("SamplesPerSecond")]
        [Validation(Required=false)]
        public double? SamplesPerSecond { get; set; }

    }

}
