// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetRoutineResponseBody : TeaModel {
        /// <summary>
        /// <para>The code versions.</para>
        /// </summary>
        [NameInMap("CodeVersions")]
        [Validation(Required=false)]
        public List<GetRoutineResponseBodyCodeVersions> CodeVersions { get; set; }
        public class GetRoutineResponseBodyCodeVersions : TeaModel {
            /// <summary>
            /// <para>The description of the code version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test ver code desc</para>
            /// </summary>
            [NameInMap("CodeDescription")]
            [Validation(Required=false)]
            public string CodeDescription { get; set; }

            /// <summary>
            /// <para>The code version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710120201067203242</para>
            /// </summary>
            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            /// <summary>
            /// <para>The time when the code version was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-11T01:23:21Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

        /// <summary>
        /// <para>The time when the routine was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-11T01:23:21Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The default record name to access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>routine1.example.com</para>
        /// </summary>
        [NameInMap("DefaultRelatedRecord")]
        [Validation(Required=false)]
        public string DefaultRelatedRecord { get; set; }

        /// <summary>
        /// <para>The description of the routine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZWRpdCByb3V0aW5lIGNvbmZpZyBkZXNjcmlwdGlvbg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The information about the environments.</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public List<GetRoutineResponseBodyEnvs> Envs { get; set; }
        public class GetRoutineResponseBodyEnvs : TeaModel {
            /// <summary>
            /// <para>The regions for canary release.</para>
            /// </summary>
            [NameInMap("CanaryAreaList")]
            [Validation(Required=false)]
            public List<string> CanaryAreaList { get; set; }

            /// <summary>
            /// <para>The version number for canary release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710120201067577628</para>
            /// </summary>
            [NameInMap("CanaryCodeVersion")]
            [Validation(Required=false)]
            public string CanaryCodeVersion { get; set; }

            /// <summary>
            /// <para>The version number of the code in the environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710120201067577628</para>
            /// </summary>
            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            /// <summary>
            /// <para>The environment type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5ms</para>
            /// </summary>
            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

        }

        /// <summary>
        /// <para>The records associated with the routine.</para>
        /// </summary>
        [NameInMap("RelatedRecords")]
        [Validation(Required=false)]
        public List<GetRoutineResponseBodyRelatedRecords> RelatedRecords { get; set; }
        public class GetRoutineResponseBodyRelatedRecords : TeaModel {
            /// <summary>
            /// <para>The record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>509348423011904</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>The record name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-record-1.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>The website ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54362329990032</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The website name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

        }

        /// <summary>
        /// <para>The routes associated with the routine.</para>
        /// </summary>
        [NameInMap("RelatedRoutes")]
        [Validation(Required=false)]
        public List<GetRoutineResponseBodyRelatedRoutes> RelatedRoutes { get; set; }
        public class GetRoutineResponseBodyRelatedRoutes : TeaModel {
            [NameInMap("ByPass")]
            [Validation(Required=false)]
            public string ByPass { get; set; }

            /// <summary>
            /// <para>The route.</para>
            /// 
            /// <b>Example:</b>
            /// <para><em>.example.com/path1</em></para>
            /// </summary>
            [NameInMap("Route")]
            [Validation(Required=false)]
            public string Route { get; set; }

            /// <summary>
            /// <para>The route ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d501cb8a2c951f32922d260040780c06</para>
            /// </summary>
            [NameInMap("RouteId")]
            [Validation(Required=false)]
            public string RouteId { get; set; }

            /// <summary>
            /// <para>The website ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54362329990032</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The website name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
