// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedCheckWarningRequest : TeaModel {
        /// <summary>
        /// <para>The language type for the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type to which the baseline belongs.</para>
        /// <remarks>
        /// <para>The <b>TypeName</b> field returned by calling the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>weak_password</para>
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// <para>The UUID of the server to query. Separate multiple UUIDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain the UUID of a server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6541631a-7d47-41fd-9fef-9518113f****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
