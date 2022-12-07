// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SubmitJobRequest : TeaModel {
        [NameInMap("ArrayRequest")]
        [Validation(Required=false)]
        public string ArrayRequest { get; set; }

        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        [NameInMap("ClockTime")]
        [Validation(Required=false)]
        public string ClockTime { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CommandLine")]
        [Validation(Required=false)]
        public string CommandLine { get; set; }

        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        [NameInMap("InputFileUrl")]
        [Validation(Required=false)]
        public string InputFileUrl { get; set; }

        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        [NameInMap("Mem")]
        [Validation(Required=false)]
        public string Mem { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Node")]
        [Validation(Required=false)]
        public int? Node { get; set; }

        [NameInMap("PackagePath")]
        [Validation(Required=false)]
        public string PackagePath { get; set; }

        [NameInMap("PostCmdLine")]
        [Validation(Required=false)]
        public string PostCmdLine { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("ReRunable")]
        [Validation(Required=false)]
        public bool? ReRunable { get; set; }

        [NameInMap("RunasUser")]
        [Validation(Required=false)]
        public string RunasUser { get; set; }

        [NameInMap("RunasUserPassword")]
        [Validation(Required=false)]
        public string RunasUserPassword { get; set; }

        [NameInMap("StderrRedirectPath")]
        [Validation(Required=false)]
        public string StderrRedirectPath { get; set; }

        [NameInMap("StdoutRedirectPath")]
        [Validation(Required=false)]
        public string StdoutRedirectPath { get; set; }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public int? Task { get; set; }

        [NameInMap("Thread")]
        [Validation(Required=false)]
        public int? Thread { get; set; }

        [NameInMap("UnzipCmd")]
        [Validation(Required=false)]
        public string UnzipCmd { get; set; }

        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

    }

}
