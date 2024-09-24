// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySasContainerWebDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The paths that are protected.</para>
        /// </summary>
        [NameInMap("PathConfDTOList")]
        [Validation(Required=false)]
        public List<ModifySasContainerWebDefenseRuleRequestPathConfDTOList> PathConfDTOList { get; set; }
        public class ModifySasContainerWebDefenseRuleRequestPathConfDTOList : TeaModel {
            /// <summary>
            /// <para>The backup paths.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audit</para>
            /// </summary>
            [NameInMap("DefenseMode")]
            [Validation(Required=false)]
            public string DefenseMode { get; set; }

            /// <summary>
            /// <para>The path that is protected.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test/home/</para>
            /// </summary>
            [NameInMap("DefensePath")]
            [Validation(Required=false)]
            public string DefensePath { get; set; }

            /// <summary>
            /// <para>The files that are excluded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/test</para>
            /// </summary>
            [NameInMap("ExcludeFile")]
            [Validation(Required=false)]
            public string ExcludeFile { get; set; }

            /// <summary>
            /// <para>The paths to the files that are excluded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/test/home/qq</para>
            /// </summary>
            [NameInMap("ExcludeFilePath")]
            [Validation(Required=false)]
            public string ExcludeFilePath { get; set; }

            /// <summary>
            /// <para>The types of the files that are excluded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>php</para>
            /// </summary>
            [NameInMap("ExcludeFileType")]
            [Validation(Required=false)]
            public string ExcludeFileType { get; set; }

            /// <summary>
            /// <para>The protection mode. Valid values:</para>
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
            /// <para>The files that are included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/admin/test</para>
            /// </summary>
            [NameInMap("IncludeFile")]
            [Validation(Required=false)]
            public string IncludeFile { get; set; }

            /// <summary>
            /// <para>The type of the files that are included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jsp</para>
            /// </summary>
            [NameInMap("IncludeFileType")]
            [Validation(Required=false)]
            public string IncludeFileType { get; set; }

            /// <summary>
            /// <para>The path ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678</para>
            /// </summary>
            [NameInMap("PathConfId")]
            [Validation(Required=false)]
            public long? PathConfId { get; set; }

            /// <summary>
            /// <para>The processes that are added to the whitelist.</para>
            /// </summary>
            [NameInMap("ProcessPathList")]
            [Validation(Required=false)]
            public List<string> ProcessPathList { get; set; }

        }

        /// <summary>
        /// <para>The ID of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200634</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wwwwwww</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
