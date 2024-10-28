// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetAppResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>MyTestApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>App</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyConfigs> Configs { get; set; }
        public class GetAppResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{     &quot;wgs.apply_bqsr.cpu&quot;: 4,     &quot;wgs.apply_bqsr.disks&quot;: &quot;local-disk 250 cloud_ssd&quot;,     &quot;wgs.apply_bqsr.gatk_Launcher&quot;: &quot;/usr/local/bin/gatk-4.1.4.1/gatk&quot;,     &quot;wgs.apply_bqsr.java_opts&quot;: &quot;\&quot;-XX:GCTimeLimit=50 -XX:GCHeapFreeLimit=10 -Xms3000m -Djava.io.tmpdir=/mnt\&quot;&quot;,     &quot;wgs.apply_bqsr.memory&quot;: &quot;8G&quot;}</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>./config/example.json</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-06-16T15:09:14.378297+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WDL content</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyDependencies> Dependencies { get; set; }
        public class GetAppResponseBodyDependencies : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>task echo {   String txt_out = &quot;default_txt_out&quot;   String dd_out = &quot;default_dd_out&quot;    command {     echo Hello &gt; ${txt_out}     /bin/bash -c &quot;dd if=/dev/zero of=${dd_out} bs=1M count=15&quot;     echo &quot;This is a test std out.&quot;   }    runtime {     cpu: &quot;2&quot;     memory: &quot;4G&quot;     autoReleaseJob: false     reserveOnFail: true     userData: &quot;key1 value1&quot;     disks: &quot;local-disk 40 cloud_ssd, /home/mount/ 40 cloud_efficiency&quot;     tag: &quot;TestTag&quot;   }    output {     File outTxtFile = &quot;${txt_out}&quot;     File outDdFile = &quot;${dd_out}&quot;   } }</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>./task/echo.wdl</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a test app</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example documentation content</para>
        /// </summary>
        [NameInMap("Documentation")]
        [Validation(Required=false)]
        public string Documentation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>easygene.cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyInputs> Inputs { get; set; }
        public class GetAppResponseBodyInputs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>help information</para>
            /// </summary>
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public long? StepOrder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestTaskName</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestVariableName</para>
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestVariableType</para>
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestVariableValue</para>
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WDL</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("LanguageVersion")]
        [Validation(Required=false)]
        public string LanguageVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-06-16T15:09:14.378297+08:00</para>
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyOutputs> Outputs { get; set; }
        public class GetAppResponseBodyOutputs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Example help information</para>
            /// </summary>
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public long? StepOrder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestTaskName</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestVariableName</para>
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Int</para>
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ExampleValue</para>
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>main.wdl</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA980AD0-158F-44F3-847D-5EAB96C0EB6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Revision")]
        [Validation(Required=false)]
        public string Revision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Example revision comment</para>
        /// </summary>
        [NameInMap("RevisionComment")]
        [Validation(Required=false)]
        public string RevisionComment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TestTag</para>
        /// </summary>
        [NameInMap("RevisionTag")]
        [Validation(Required=false)]
        public string RevisionTag { get; set; }

        [NameInMap("Revisions")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyRevisions> Revisions { get; set; }
        public class GetAppResponseBodyRevisions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-06-16T15:09:14.378297+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Revision")]
            [Validation(Required=false)]
            public string Revision { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Example revision comment</para>
            /// </summary>
            [NameInMap("RevisionComment")]
            [Validation(Required=false)]
            public string RevisionComment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ProduceVersion</para>
            /// </summary>
            [NameInMap("RevisionTag")]
            [Validation(Required=false)]
            public string RevisionTag { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EasyGene</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Example url</para>
        /// </summary>
        [NameInMap("URL")]
        [Validation(Required=false)]
        public string URL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MyTestWorkflow</para>
        /// </summary>
        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TestWorkspace</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
