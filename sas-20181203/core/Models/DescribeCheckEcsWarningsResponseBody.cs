// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckEcsWarningsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the current Security Center edition is a trial version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: not a trial version</description></item>
        /// <item><description><b>1</b>: a trial version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CanTry")]
        [Validation(Required=false)]
        public string CanTry { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E5BFDCF-B9DD-430D-9DA4-151BCB581C9D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The edition of Security Center that you purchased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition</description></item>
        /// <item><description><b>2</b> or <b>3</b>: Enterprise Edition  </description></item>
        /// <item><description><b>5</b>: Premium Edition  </description></item>
        /// <item><description><b>6</b>: Anti-virus Edition</description></item>
        /// </list>
        /// <remarks>
        /// <para>Both 2 and 3 correspond to Enterprise Edition. There is no difference between the two values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SasVersion")]
        [Validation(Required=false)]
        public string SasVersion { get; set; }

        /// <summary>
        /// <para>The number of high-risk weak password risks detected in your assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("WeakPasswordCount")]
        [Validation(Required=false)]
        public string WeakPasswordCount { get; set; }

    }

}
