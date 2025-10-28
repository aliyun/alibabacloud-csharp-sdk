// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Instance : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0.444</para>
        /// </summary>
        [NameInMap("CurrentAmount")]
        [Validation(Required=false)]
        public float? CurrentAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.168.1.100</para>
        /// </summary>
        [NameInMap("ExternalIP")]
        [Validation(Required=false)]
        public string ExternalIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("ExternalInstancePort")]
        [Validation(Required=false)]
        public int? ExternalInstancePort { get; set; }

        [NameInMap("HostIP")]
        [Validation(Required=false)]
        public string HostIP { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("InnerIP")]
        [Validation(Required=false)]
        public string InnerIP { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("InstancePort")]
        [Validation(Required=false)]
        public int? InstancePort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs.c7.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("IsLatest")]
        [Validation(Required=false)]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsSpot")]
        [Validation(Required=false)]
        public bool? IsSpot { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Isolated")]
        [Validation(Required=false)]
        public bool? Isolated { get; set; }

        [NameInMap("LastState")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> LastState { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.2</para>
        /// </summary>
        [NameInMap("OriginalAmount")]
        [Validation(Required=false)]
        public float? OriginalAmount { get; set; }

        [NameInMap("ReadyProcesses")]
        [Validation(Required=false)]
        public int? ReadyProcesses { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PublicResource</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("RestartCount")]
        [Validation(Required=false)]
        public int? RestartCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("StartAt")]
        [Validation(Required=false)]
        [Obsolete]
        public string StartAt { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.168.0.39</para>
        /// </summary>
        [NameInMap("TenantHostIP")]
        [Validation(Required=false)]
        public string TenantHostIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.168.0.39</para>
        /// </summary>
        [NameInMap("TenantInstanceIP")]
        [Validation(Required=false)]
        public string TenantInstanceIP { get; set; }

        [NameInMap("TotalProcesses")]
        [Validation(Required=false)]
        public int? TotalProcesses { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai-a</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
