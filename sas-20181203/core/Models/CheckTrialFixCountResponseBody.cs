// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CheckTrialFixCountResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the vulnerability can be fixed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CanFix")]
        [Validation(Required=false)]
        public bool? CanFix { get; set; }

        /// <summary>
        /// <para>The quota usage required for the current fix operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ExpendCount")]
        [Validation(Required=false)]
        public int? ExpendCount { get; set; }

        /// <summary>
        /// <para>The quota that remains after the current fix operation is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RemainCount")]
        [Validation(Required=false)]
        public int? RemainCount { get; set; }

        /// <summary>
        /// <para>The number of the vulnerabilities that are fixed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RepairedCount")]
        [Validation(Required=false)]
        public int? RepairedCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether Security Center is in free trial. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isTrial")]
        [Validation(Required=false)]
        public bool? IsTrial { get; set; }

    }

}
