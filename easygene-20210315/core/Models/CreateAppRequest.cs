// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class CreateAppRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestApp</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>TestToken</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<CreateAppRequestConfigs> Configs { get; set; }
        public class CreateAppRequestConfigs : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>import &quot;./task/echo.wdl&quot; as echo workflow wf_echo {   call echo.echo }</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public List<CreateAppRequestDependencies> Dependencies { get; set; }
        public class CreateAppRequestDependencies : TeaModel {
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
        /// <para>Example documentation content</para>
        /// </summary>
        [NameInMap("Documentation")]
        [Validation(Required=false)]
        public string Documentation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main.wdl</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestWorkspace</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
