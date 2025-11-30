// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertJobConfig : TeaModel {
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public List<MediaConvertJobConfigInputs> Inputs { get; set; }
        public class MediaConvertJobConfigInputs : TeaModel {
            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public MediaConvertJobConfigInputsInputFile InputFile { get; set; }
            public class MediaConvertJobConfigInputsInputFile : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("OutputGroups")]
        [Validation(Required=false)]
        public List<MediaConvertJobConfigOutputGroups> OutputGroups { get; set; }
        public class MediaConvertJobConfigOutputGroups : TeaModel {
            [NameInMap("GroupConfig")]
            [Validation(Required=false)]
            public MediaConvertJobConfigOutputGroupsGroupConfig GroupConfig { get; set; }
            public class MediaConvertJobConfigOutputGroupsGroupConfig : TeaModel {
                [NameInMap("ManifestExtend")]
                [Validation(Required=false)]
                public MediaConvertJobConfigOutputGroupsGroupConfigManifestExtend ManifestExtend { get; set; }
                public class MediaConvertJobConfigOutputGroupsGroupConfigManifestExtend : TeaModel {
                    [NameInMap("Excludes")]
                    [Validation(Required=false)]
                    public List<MediaConvertJobConfigOutputGroupsGroupConfigManifestExtendExcludes> Excludes { get; set; }
                    public class MediaConvertJobConfigOutputGroupsGroupConfigManifestExtendExcludes : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("language")]
                        [Validation(Required=false)]
                        public string Language { get; set; }

                    }

                    [NameInMap("InputRef")]
                    [Validation(Required=false)]
                    public string InputRef { get; set; }

                }

                [NameInMap("ManifestName")]
                [Validation(Required=false)]
                public string ManifestName { get; set; }

                [NameInMap("OutputFileBase")]
                [Validation(Required=false)]
                public MediaConvertJobConfigOutputGroupsGroupConfigOutputFileBase OutputFileBase { get; set; }
                public class MediaConvertJobConfigOutputGroupsGroupConfigOutputFileBase : TeaModel {
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public List<MediaConvertJobConfigOutputGroupsOutputs> Outputs { get; set; }
            public class MediaConvertJobConfigOutputGroupsOutputs : TeaModel {
                [NameInMap("Features")]
                [Validation(Required=false)]
                public string Features { get; set; }

                [NameInMap("HlsGroupConfig")]
                [Validation(Required=false)]
                public MediaConvertJobConfigOutputGroupsOutputsHlsGroupConfig HlsGroupConfig { get; set; }
                public class MediaConvertJobConfigOutputGroupsOutputsHlsGroupConfig : TeaModel {
                    [NameInMap("AudioGroup")]
                    [Validation(Required=false)]
                    public string AudioGroup { get; set; }

                    [NameInMap("AutoSelect")]
                    [Validation(Required=false)]
                    public string AutoSelect { get; set; }

                    [NameInMap("Forced")]
                    [Validation(Required=false)]
                    public string Forced { get; set; }

                    [NameInMap("Group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public string IsDefault { get; set; }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SubtitleGroup")]
                    [Validation(Required=false)]
                    public string SubtitleGroup { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OutputFileName")]
                [Validation(Required=false)]
                public string OutputFileName { get; set; }

                [NameInMap("OverrideParams")]
                [Validation(Required=false)]
                public string OverrideParams { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

            }

        }

    }

}
