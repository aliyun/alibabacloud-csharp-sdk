// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppServiceProfile : TeaModel {
        /// <summary>
        /// <para>The business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20250801003834000003</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The design type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Language_Pack</para>
        /// </summary>
        [NameInMap("DesignType")]
        [Validation(Required=false)]
        public string DesignType { get; set; }

        /// <summary>
        /// <para>The design type description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Language pack</para>
        /// </summary>
        [NameInMap("DesignTypeText")]
        [Validation(Required=false)]
        public string DesignTypeText { get; set; }

        /// <summary>
        /// <para>The Lingxiao instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lx-1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256146659280026</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The service specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("ServiceSpec")]
        [Validation(Required=false)]
        public string ServiceSpec { get; set; }

        /// <summary>
        /// <para>The service specification description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic edition</para>
        /// </summary>
        [NameInMap("ServiceSpecText")]
        [Validation(Required=false)]
        public string ServiceSpecText { get; set; }

    }

}
