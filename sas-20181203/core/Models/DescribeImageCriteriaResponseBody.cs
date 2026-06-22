// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageCriteriaResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of image query criteria.</para>
        /// </summary>
        [NameInMap("CriteriaList")]
        [Validation(Required=false)]
        public List<DescribeImageCriteriaResponseBodyCriteriaList> CriteriaList { get; set; }
        public class DescribeImageCriteriaResponseBodyCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the query criterion.</para>
            /// <list type="bullet">
            /// <item><description><b>tag</b>: image tag.</description></item>
            /// <item><description><b>digest</b>: image digest.</description></item>
            /// <item><description><b>vulStatus</b>: vulnerability status.</description></item>
            /// <item><description><b>alarmStatus</b>: security alert status.</description></item>
            /// <item><description><b>riskStatus</b>: risk status.</description></item>
            /// <item><description><b>registryType</b>: image repository type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vulStatus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the query criterion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>input</b>: requires manual input of the query field.</description></item>
            /// <item><description><b>select</b>: requires selecting a subtype from a drop-down list.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>input</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The available option values when <b>Type</b> (the type of the query criterion) is <b>select</b>.</para>
            /// <remarks>
            /// <para>When <b>Type</b> (the type of the query criterion) is <b>input</b>, this parameter returns an empty value.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>NO,YES</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413BB68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
