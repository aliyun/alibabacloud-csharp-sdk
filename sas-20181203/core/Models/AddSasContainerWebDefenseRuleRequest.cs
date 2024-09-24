// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddSasContainerWebDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The paths that you want to protect.</para>
        /// </summary>
        [NameInMap("PathConfDTOList")]
        [Validation(Required=false)]
        public List<AddSasContainerWebDefenseRuleRequestPathConfDTOList> PathConfDTOList { get; set; }
        public class AddSasContainerWebDefenseRuleRequestPathConfDTOList : TeaModel {
            /// <summary>
            /// <para>The backup path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/test</para>
            /// </summary>
            [NameInMap("BackupPath")]
            [Validation(Required=false)]
            public string BackupPath { get; set; }

            /// <summary>
            /// <para>The prevention mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>block</b></description></item>
            /// <item><description><b>audit</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>audit</para>
            /// </summary>
            [NameInMap("DefenseMode")]
            [Validation(Required=false)]
            public string DefenseMode { get; set; }

            /// <summary>
            /// <para>The path that you want to protect.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/test/</para>
            /// </summary>
            [NameInMap("DefensePath")]
            [Validation(Required=false)]
            public string DefensePath { get; set; }

            /// <summary>
            /// <para>The file that you want to exclude.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/test/aa</para>
            /// </summary>
            [NameInMap("ExcludeFile")]
            [Validation(Required=false)]
            public string ExcludeFile { get; set; }

            /// <summary>
            /// <para>The path to the file that you want to exclude.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/test/tt</para>
            /// </summary>
            [NameInMap("ExcludeFilePath")]
            [Validation(Required=false)]
            public string ExcludeFilePath { get; set; }

            /// <summary>
            /// <para>The type of the file that you want to exclude.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jsp</para>
            /// </summary>
            [NameInMap("ExcludeFileType")]
            [Validation(Required=false)]
            public string ExcludeFileType { get; set; }

            /// <summary>
            /// <para>The protecion mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: basic mode (whitelist)</description></item>
            /// <item><description><b>1</b>: complex mode (blacklist)</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GuardType")]
            [Validation(Required=false)]
            public int? GuardType { get; set; }

            /// <summary>
            /// <para>The file that you want to include.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/test/t1</para>
            /// </summary>
            [NameInMap("IncludeFile")]
            [Validation(Required=false)]
            public string IncludeFile { get; set; }

            /// <summary>
            /// <para>The type of the file that you want to include.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.jsp</para>
            /// </summary>
            [NameInMap("IncludeFileType")]
            [Validation(Required=false)]
            public string IncludeFileType { get; set; }

            /// <summary>
            /// <para>The processes that you want to add to the whitelist.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ProcessPathList")]
            [Validation(Required=false)]
            public List<string> ProcessPathList { get; set; }

        }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-2020</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
