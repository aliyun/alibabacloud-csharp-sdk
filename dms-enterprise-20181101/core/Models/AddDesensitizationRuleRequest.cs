// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddDesensitizationRuleRequest : TeaModel {
        /// <summary>
        /// <para>The parameters of the algorithm.</para>
        /// </summary>
        [NameInMap("FunctionParams")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> FunctionParams { get; set; }

        /// <summary>
        /// <para>The type of the masking algorithm.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FIX_POS : masks characters in the specified position.</description></item>
        /// <item><description>DATE_ROUNDING: rounds the date.</description></item>
        /// <item><description>PLAINTEXT: does not mask data.</description></item>
        /// <item><description>SHA1: masks characters by using the secure hash algorithm 1 (SHA-1)</description></item>
        /// <item><description>HMAC: masks characters by using the hash-based message authentication code (HMAC).</description></item>
        /// <item><description>STRING_TRANSFORM: shift characters.</description></item>
        /// <item><description>NUMBER_ROUNDING: rounds numbers.</description></item>
        /// <item><description>AES: masks characters by using the advanced encryption standard (AES) algorithm.</description></item>
        /// <item><description>SHA256: masks characters by using SHA-256 algorithm.</description></item>
        /// <item><description>DES: masks characters by using the data encryption standard (DES) algorithm.</description></item>
        /// <item><description>MAP_REPLACE: masks the mapped data.</description></item>
        /// <item><description>FIX_CHAR: masks fixed characters.</description></item>
        /// <item><description>DEFAULT: masks all characters.</description></item>
        /// <item><description>RANDOM_REPLACE: randomly replaces characters.</description></item>
        /// <item><description>MD5: masks characters by using the MD5 algorithm.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MD5</para>
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <para>The description of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hash algorithm</para>
        /// </summary>
        [NameInMap("RuleDescription")]
        [Validation(Required=false)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desensitization algorithm test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The masking algorithm.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PLAINTEXT</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>TRANSFORM</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>ENCRYPT</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>REPLACE</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>HASH</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>MASK</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HASH</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <remarks>
        /// <para> To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the <a href="https://help.aliyun.com/document_detail/181330.html">View information about the current tenant</a> section of the &quot;Manage DMS tenants&quot; topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
