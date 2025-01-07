// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckEcsWarningsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether you use the free trial of Security Center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CanTry")]
        [Validation(Required=false)]
        public string CanTry { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E5BFDCF-B9DD-430D-9DA4-151BCB581C9D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The edition of Security Center that you use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Basic edition</description></item>
        /// <item><description><b>2</b> or <b>3</b>: Enterprise edition</description></item>
        /// <item><description><b>5</b>: Advanced edition</description></item>
        /// <item><description><b>6</b>: Anti-virus edition</description></item>
        /// </list>
        /// <remarks>
        /// <para> Both the value 2 and the value 3 indicate the Enterprise edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SasVersion")]
        [Validation(Required=false)]
        public string SasVersion { get; set; }

        /// <summary>
        /// <para>The number of weak passwords that can cause high risks to your assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("WeakPasswordCount")]
        [Validation(Required=false)]
        public string WeakPasswordCount { get; set; }

    }

}
