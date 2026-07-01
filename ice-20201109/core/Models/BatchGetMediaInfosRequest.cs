// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchGetMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>The types of additional media asset information to return. If this parameter is not specified, only basic information is returned. Valid values are:</para>
        /// <para>-FileInfo</para>
        /// <para>-DynamicMetaData</para>
        /// 
        /// <b>Example:</b>
        /// <para>FileInfo,DynamicMetaData</para>
        /// </summary>
        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

        /// <summary>
        /// <para>The authentication timeout, in seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>Minimum value: <b>1</b>.</para>
        /// </description></item>
        /// <item><description><para>Maximum value: 86400.</para>
        /// </description></item>
        /// <item><description><para>Default value: 3600.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>A comma-separated list of media asset IDs to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>b48fb04483915d4f2cd8</b></b></b>,<b><b><b>c48fb37407365d4f2cd8</b></b></b></para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
