// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class StartUserAppAsyncEnhanceInMsaRequest : TeaModel {
        [NameInMap("ApkProtector")]
        [Validation(Required=false)]
        public bool? ApkProtector { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AssetsFileList")]
        [Validation(Required=false)]
        public string AssetsFileList { get; set; }

        [NameInMap("Classes")]
        [Validation(Required=false)]
        public string Classes { get; set; }

        [NameInMap("DalvikDebugger")]
        [Validation(Required=false)]
        public int? DalvikDebugger { get; set; }

        [NameInMap("EmulatorEnvironment")]
        [Validation(Required=false)]
        public int? EmulatorEnvironment { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("JavaHook")]
        [Validation(Required=false)]
        public int? JavaHook { get; set; }

        [NameInMap("MemoryDump")]
        [Validation(Required=false)]
        public int? MemoryDump { get; set; }

        [NameInMap("NativeDebugger")]
        [Validation(Required=false)]
        public int? NativeDebugger { get; set; }

        [NameInMap("NativeHook")]
        [Validation(Required=false)]
        public int? NativeHook { get; set; }

        [NameInMap("PackageTampered")]
        [Validation(Required=false)]
        public int? PackageTampered { get; set; }

        [NameInMap("Root")]
        [Validation(Required=false)]
        public int? Root { get; set; }

        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        [NameInMap("SoFileList")]
        [Validation(Required=false)]
        public string SoFileList { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("TotalSwitch")]
        [Validation(Required=false)]
        public bool? TotalSwitch { get; set; }

        [NameInMap("UseAShield")]
        [Validation(Required=false)]
        public bool? UseAShield { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
