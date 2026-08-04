// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class WorkspaceSpec : TeaModel {
        /// <summary>
        /// <para>Invalidity reason code when using guaranteed resources is invalid</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Type of invalidity reason when using guaranteed resources is invalid</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("CodeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        /// <summary>
        /// <para>Indicates whether the use of guaranteed resources is valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsGuaranteedValid")]
        [Validation(Required=false)]
        public bool? IsGuaranteedValid { get; set; }

        /// <summary>
        /// <para>Indicates whether the use of oversold resources is valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsOverSoldValid")]
        [Validation(Required=false)]
        public bool? IsOverSoldValid { get; set; }

        /// <summary>
        /// <para>Invalidity reason content when using guaranteed resources is invalid</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>Specification resource information</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public ResourceAmount Spec { get; set; }

        /// <summary>
        /// <para>Template Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>spec_test</para>
        /// </summary>
        [NameInMap("SpecName")]
        [Validation(Required=false)]
        public string SpecName { get; set; }

    }

}
