// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ResumeJobsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>de48407d-309e-451a-81ec-6fb11f8fdbf3</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b72425bd-7871-4050-838e-033d80d754b7</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public List<string> JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d5971d98-7312-4f0e-a918-a17d67133e28</para>
        /// </summary>
        [NameInMap("JobReferenceId")]
        [Validation(Required=false)]
        public List<string> JobReferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b016fbdb-b81c-4c06-8870-cb36b8783b6d</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

    }

}
