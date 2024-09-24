// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeUserQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The available elastic AnalyticDB compute units (ACUs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>512ACU</para>
        /// </summary>
        [NameInMap("ElasticACU")]
        [Validation(Required=false)]
        public string ElasticACU { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0322C7FB-4584-5D2A-BF7F-F9036E940C35</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The available reserved computing resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48ACU</para>
        /// </summary>
        [NameInMap("ReserverdCompteACU")]
        [Validation(Required=false)]
        public string ReserverdCompteACU { get; set; }

        /// <summary>
        /// <para>The available reserved storage resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24ACU</para>
        /// </summary>
        [NameInMap("ReserverdStorageACU")]
        [Validation(Required=false)]
        public string ReserverdStorageACU { get; set; }

        /// <summary>
        /// <para>The number of available resource groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ResourceGroupCount")]
        [Validation(Required=false)]
        public string ResourceGroupCount { get; set; }

    }

}
